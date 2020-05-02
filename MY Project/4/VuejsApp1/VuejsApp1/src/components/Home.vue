<template>
    <div>
        
            <QuestionList />
        <hr>
       
        <AddQuestion @Send-Question="CreateQuestion" @Send-Answer="CreateAnswer" />
       
    </div>
      
</template>

<script>
    import AddQuestion from './AddQuestion.vue';
    import QuestionList from './QuestionList.vue';
    export default {
        data() {
            return {
                
                QuestionId: "",
                urlQ: 'https://localhost:44319/questions',
                urlA: 'https://localhost:44319/answers',
                

            }
        },
        components: {
            AddQuestion,
            QuestionList

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

                fetch(this.urlQ).then(response => response.json()).then(commits => this.questions = commits);

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


<style scoped>
</style>

