<template>
    <div id="app">

        <QuestionList />
        <!--<AddQuestion @Send-Question="CreateQuestion" @Send-Answer="CreateAnswer" />
        <p>Id: {{QuestionId}}</p>-->
        


    </div>
</template>

<script>
    import QuestionList from './components/QuestionList.vue';
    import AddQuestion from './components/AddQuestion.vue';
    

    export default {
        name: 'app',
        data() {
            return {
               questions: "",
                QuestionId: "",
                urlQ: 'https://localhost:44319/questions',
                urlA: 'https://localhost:44319/answers'                
                
            }
        },
        components: {
            QuestionList,
            AddQuestion,
           
        },
        methods: {
            
            CreateQuestion(value) {
                fetch(this.urlQ,
                    {
                        method: 'POST',
                        headers: { "Accept": "application/json", "Content-Type": "application/json" },
                        body: JSON.stringify({ questionText: value })
                    })
                    .then(response => response.json())
                    .then(data => this.QuestionId = data.id);
            },
            CreateAnswer(value) {
                fetch(this.urlA,
                    {
                        method: 'POST',
                        headers: { "Accept": "application/json", "Content-Type": "application/json" },
                        body: JSON.stringify({ answerText: value, QuestionId: this.QuestionId })
                    })
                    
            },            
           
        }
    };
</script>

<style>
</style>

