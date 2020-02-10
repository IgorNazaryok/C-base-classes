const dragAndDroup = () =>{
const tasks = document.querySelectorAll('.js-task');
const lists = document.querySelectorAll('.js-list');
let activeTask;
let activePlace;

const dragStart = function(){
//console.log('dragStart')
this.style.background = 'orange';
  
activeTask=this;

//console.log(activeTask)	
};

const dragEnd = function(ev){
	//console.log('dragStart')
	this.style.background = '#070';
	
	activeTask=this;
	console.log('X: '+ev.pageX);
	console.log('X: '+ev.pageY);
	
	//console.log(activeTask)	
	};

const dragOver = function(evt){
	evt.preventDefault();
	//console.log('dragOver');
	};

const dragEnter = function(ev){
	this.style.borderColor='red';
	ev.target;
	//console.log(lists);
	
	
	};

const dragLeave = function(){
	//console.log('dragLeave');
	//activePlace=null;
	this.style.borderColor='white';
	};
	

const dragDroup = function(){
	
	//console.log(activeTask.target.id);	
	//this.append(activeTask);
	this.style.borderColor='white';
	this.append(activeTask);	
	};	

	const mouseUp = function(ev){
	
		//console.log(activeTask.target.id);	
		//this.append(activeTask);
		console.log('X: '+ev.pageX);
		console.log('X: '+ev.pageY);
		};		
	


//--------------------------------------------------
tasks.forEach((task) =>{
task.addEventListener('dragstart',dragStart);
task.addEventListener('dragend',dragEnd);
/*task.addEventListener('dragover',dragOver);
task.addEventListener('dragenter',dragEnter);
task.addEventListener('dragleave',dragLeave);
task.addEventListener('drop',dragDroup);
*/});


lists.forEach((list) =>{
	list.addEventListener('dragover',dragOver);
	list.addEventListener('dragenter',dragEnter);
	list.addEventListener('dragleave',dragLeave);
	list.addEventListener('drop',dragDroup);
	//list.addEventListener('mouseup',mouseUp);
});



};
dragAndDroup()