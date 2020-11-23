const windowInnerWidth = window.outerWidth;
const windowInnerHeight = window.outerHeight;
const NUMOFOCTAVES = 4; //number of octaves
var keyWidth;
var p5Keys = {};
let keyboard = {};
let note;
let polySynth1;
let aTime; //attack time
let aLevel; //attack level
let dTime;//decay time in seconds
let dLevel; //decay level  0.0 to 1.0



function setup() {

	//attack, decay setup
	aTime = 0.05;
	aLevel = 1;
	dTime = 0.5;
	dLevel = 1;
	

	polySynth1 = new p5.PolySynth();

	let cnv = createCanvas(800, 200);
	strokeWeight(4);
	stroke(255);
	polySynth1.setADSR(0,01, 1, 0.1, 0.5);

	//Keyboard mapping
	keyboard["a"] = "G#3";
	keyboard["z"] = "A4";
	keyboard["s"] = "A#4";
	keyboard["x"] = "B4";
	keyboard["c"] = "C4";
	keyboard["f"] = "C#4";
	keyboard["v"] = "D4";
	keyboard["g"] = "D#4";
	keyboard["b"] = "E4";
	keyboard["n"] = "F4";
	keyboard["j"] = "F#4";
	keyboard["m"] = "G4";
	keyboard["k"] = "G#4";
	keyboard[","] = "A5";
	keyboard["l"] = "A#5";
	keyboard["."] = "B5";

}

function keyPressed() {
getAudioContext().resume();
	playSynth(key);
}

function playSynth(key) {
userStartAudio();

	let note = keyboard[key];
	polySynth1.noteAttack(note);
}

function keyReleased(){
	let note = keyboard[key];
	polySynth1.noteRelease(note);
}

function drawKeys(){
	setup();

	keyWidth = 60;
	let keyWidthString = '60px';
	//let numOfOctaves = document.getElementById('octaveNumberInput1').value;
	let numOfOctaves = NUMOFOCTAVES;
	var startNote = 60;

	if (numOfOctaves == 3){
		startNote = 48;
	}
	else if (numOfOctaves > 3){
		keyWidth = Math.floor(windowInnerWidth / (numOfOctaves * 7));
		keyWidthString  = keyWidth + 'px';
		if (numOfOctaves == 4){
			startNote = 36;
		}
		else{
			startNote = 24;
		}
	}

	document.body.style.setProperty("--keyWidth", keyWidthString );

	for (let index = 0; index < numOfOctaves; index++){
		drawOneOctave(startNote);
		startNote += 12;
	}

	document.getElementById('octaveNumberInput1').style.display = 'none';
	document.getElementById('buttonCreate').style.display = 'none';
}

function drawOneOctave(startNote){
	let parentDiv = document.querySelector('.keyboard');
	let notes = ["C", "C#", "D","D#", "E", "F", "F#", "G", "G#", "A", "A#", "B"];

	for (let index = 0; index < notes.length; index++) {
		let button = document.createElement("div");
		button.className = "keyButton white";
		button.name = notes[index];
		button.innerHTML = notes[index];
		button.id = "key"+ (startNote + index).toString();
		if(notes[index].includes('#')){
			button.className = "keyButton black";
		}

		button.addEventListener('mousedown', (e) => {polySynth1.noteAttack(midiToFreq(startNote + index));
								button.classList.add('active');
		});
		//button.addEventListener('mousedown', (e) => playNote(notes[index] + '4'));
		button.addEventListener('mouseup', (e) => {polySynth1.noteRelease(midiToFreq(startNote + index));
								button.classList.remove('active');
		});
		//button.addEventListener('mouseup', (e) => stopNote(notes[index] + '4'));
		button.addEventListener('mouseleave', (e) => {polySynth1.noteRelease(midiToFreq(startNote + index));
								button.classList.remove('active');
		});
		parentDiv.appendChild(button);
	}
}
