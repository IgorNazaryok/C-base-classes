<template>
    <div>
        
            <QuestionList />
        <hr>
      
        <AddQuestion v-show="this.$parent.$data.UserSession" @Send-Question="CreateQuestion" @Send-Answer="CreateAnswer" />
       
    </div>
      
</template>

<script>
    import AddQuestion from './AddQuestion.vue';
    import QuestionList from './QuestionList.vue';
    export default {
        data() {
            return {                
                QuestionId: "", 
            }
        },
        components: {
            AddQuestion,
            QuestionList

        },
        methods: {

            CreateQuestion(value) {
                fetch('https://localhost:44319/questions',
                    {
                        method: 'POST',
                        headers: { "Accept": "application/json", "Content-Type": "application/json" },
                        body: JSON.stringify({ questionText: value })
                    })
                    .then(response => response.json())
                    .then(data => this.QuestionId = data.id);

                fetch('https://localhost:44319/questions').then(response => response.json()).then(commits => this.questions = commits);

            },
            CreateAnswer(value) {
                fetch('https://localhost:44319/answers',
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

