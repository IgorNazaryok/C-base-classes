<template>
    <section>
        <div>

            <button @click="Get('https://localhost:44319/questions')">Загрузить список вопросов </button>


            <ul class="radio-list">
                <li v-for="(question, id) in questions" :key="id">
                    <p id="block1">
                        {{ question.questionText }}
                        <button :value="question.id" @click="GetActiveQuestionsAnswer">Открыть</button>
                        
                    </p>
                </li>
            </ul>
            
            <Voting :active-question="activeQuestion" :initial-visible="initialVisible" :active-answers="activeAnswers" @Send-Answer="addAnswer"/>
        </div>
       
        

    </section>
</template>
<script>    
    import Voting from './Voting.vue';
 
    export default {
        props:
            ['questions',
            ],
        data() {
            return {
            activeQuestion:"",
            activeQuestionId:1,
            activeAnswers:"",
            initialVisible: false,
            urlA: 'https://localhost:44319/answers',
            }
    },
        components: {
            Voting,
           
        },
        methods: {

            Get(url) {
                fetch(url).then(response => response.json()).then(commits => this.questions = commits);
            },
            GetActiveQuestionsAnswer(event) {
                this.initialVisible = true;                
                this.activeQuestionId = Number(event.target.value);                 
                fetch("https://localhost:44319/questions/" + this.activeQuestionId).then(response => response.json())
                    .then(commits => this.activeQuestion = commits);
                fetch("https://localhost:44319/answers/" + this.activeQuestionId).then(response => response.json())
                    .then(commits => this.activeAnswers = commits);
            },
            addAnswer(value) {
                fetch(this.urlA,
                    {
                        method: 'POST',
                        headers: { "Accept": "application/json", "Content-Type": "application/json" },
                        body: JSON.stringify({ answerText: value, QuestionId: this.activeQuestionId })
                    })
            },
            
           
        }
    }

</script>
<style>
    #block1 {
        
        width: 30%;
        
        border: 1px solid gray;
        border-radius: 10px;
        margin: 10px;
        padding: 10px;
        background-color: silver;
    }
    #block2 {
       
        
        border: none;
        margin: 10px;
        padding: 10px;
    }
    .radio-list {
        list-style: none;
    }
</style>