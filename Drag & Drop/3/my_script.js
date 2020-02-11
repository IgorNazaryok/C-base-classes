const dragAndDroup = () =>{
    const tasks = document.querySelectorAll('.js-task');
    const lists = document.querySelectorAll('.js-list');
    let activeTask;
    let activePlace;
    let num;

    const dragStart = function(){
        activeTask=this;
        this.style.background = 'orange';
    };

    const dragOver = function(e){       
        e.preventDefault();       
        if(e.target.classList.contains('js-task')) {
            e.target.classList.add('over-this-el')
            num=e.srcElement.id;
        }
    };

    const dragEnter = function(){
        this.style.borderColor='red';
    };

    const dragLeave = function(e){

        e.target.classList.remove('over-this-el')
        this.style.borderColor='white';
    };


    const dragDroup = function(e){
        e.target.classList.remove('over-this-el')
        if(e.target.classList.contains('js-task')) {        
        activePlace=document.getElementById(num);
        console.log(num);
        this.insertBefore(activeTask, activePlace);        
        }
        else
        this.append(activeTask);
         this.style.borderColor='white';
    };
    
    const dragEnd = function(ev){        
        this.style.background = '#070';        
        };

//--------------------------------------------------
    tasks.forEach((task) =>{
        task.addEventListener('dragstart',dragStart);
        task.addEventListener('dragend',dragEnd);
    });

    lists.forEach((list) =>{
        list.addEventListener('dragover',dragOver);
        list.addEventListener('dragenter',dragEnter);
        list.addEventListener('dragleave',dragLeave);
        list.addEventListener('drop',dragDroup);
    });



};
dragAndDroup()
