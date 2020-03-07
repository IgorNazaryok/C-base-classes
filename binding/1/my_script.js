  const pricing = {
    "studio": 10,
    "1bed": 15,
    "2bed": 20
  }
  let model = {
    startdate: "2020-02-20",
    enddate: "2020-02-22",
    room: "2bed",
    sum: 30
  }
 
function mybinder(i, _string) {
  
  if(i)
  {     
    this[_string]=event.target.value;   
      }
  else 
  {
    event.target.value=this[_string];
  }
}
  var b=mybinder.bind(model);
 
  function calc() {
   
    if(model.startdate && model.enddate && model.room) {
      const days = Math.round((new Date(model.enddate) - new Date(model.startdate))/(24*60*60*1000));      
      if(pricing[model.room]) {
        model.sum = pricing[model.room] * days;        
      }
    } 
    let str = "Стоимость "+ days +" в выбранном отеле стоит " +sum;  
    sum.value=str;   
  }
