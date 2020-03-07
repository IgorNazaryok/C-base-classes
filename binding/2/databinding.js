(function (){

var elements = document.querySelectorAll('[bind-attribute]');
   // var dbrepo = {};

    let dbrepo = {
        startdate: "2020-03-01",
        enddate: "2020-03-22",
        hotel: "2bed",          
      }
      const pricing = {
        "studio": 10,
        "1bed": 15,
        "2bed": 20
      }  

    elements.forEach((element) => {

       
            var bindingProperty = element.getAttribute('bind-attribute');
            if(dbrepo[bindingProperty]){
                element.value=dbrepo[bindingProperty];
            } 
            
          console.log(bindingProperty);
           addToScope();
           if(element.type === 'date')
            element.oninput = () => {
                dbrepo[bindingProperty] = element.value;
                calc();
                console.log(dbrepo[bindingProperty]);
           }
           
           if(element.type !== 'date')
           element.onchange = () => {              
                dbrepo[bindingProperty] = element.value;
                calc();
                console.log(dbrepo.hotel);            
           }
           
           function calc() {           
           if(dbrepo.startdate && dbrepo.enddate && dbrepo.hotel) {
              const days = Math.round((new Date(dbrepo.enddate) - new Date(dbrepo.startdate))/(24*60*60*1000));      
              if(pricing[dbrepo.hotel]) {
                var sum = pricing[dbrepo.hotel] * days;                
              }
             dbrepo.summa = "Cost " + days + " days in the selected hotel constitutes " + sum + " euro" ; 
             console.log(dbrepo.summa);             
           }             
          }       

        function addToScope() {
            if (!dbrepo.hasOwnProperty(bindingProperty)) {
                let value;
                Object.defineProperty(dbrepo, bindingProperty, {
                    configurable: true,
                    enumerable: true,
                    set: function (newvalue) {
                        value = newvalue;
                        elements.forEach(e => {
                            if (e.getAttribute('bind-attribute') === bindingProperty) {                                
                                    e.value = newvalue
                            }
                        })
                    },
                    get: function () {
                        return value;
                    }
                })
            }
        }

    });

})();