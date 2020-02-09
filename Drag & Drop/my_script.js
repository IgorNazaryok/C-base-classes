const dragAndDroup = () =>{
const tasks = document.querySelectorAll('.js-task');
const lists = document.querySelectorAll('.js-list');
let activeTask;
let activePlace;

const dragStart = function(){
//console.log('dragStart')
activeTask=this;
//console.log(activeTask)	
};

const dragOver = function(evt){
	evt.preventDefault();
	//console.log('dragOver');
	};

const dragEnter = function(){
	//console.log('dragEnter');
	//activePlace=this;
	//console.log(activePlace);
	};

const dragLeave = function(){
	//console.log('dragLeave');
	//activePlace=null;
	};
	

const dragDroup = function(){
	
	//console.log(activePlace);	
	this.append(activeTask);
	
	//this.prepend(activeTask);	
	};	
	


//--------------------------------------------------
tasks.forEach((task) =>{
task.addEventListener('dragstart',dragStart);
});

lists.forEach((list) =>{
	list.addEventListener('dragover',dragOver);
	list.addEventListener('dragenter',dragEnter);
	list.addEventListener('dragleave',dragLeave);
	list.addEventListener('drop',dragDroup);
});



};
dragAndDroup()