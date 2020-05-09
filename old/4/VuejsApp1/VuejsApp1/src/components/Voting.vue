<template>
    <section>
        <div>
            <button @click="GetActiveQuestionsAnswer($route.params.id)">Загрузить список вопросов </button>
            <h4 id="question">{{ activeQuestion.questionText }}</h4>
            <ul class="radio-list">
                <li v-for="(activeAnswer, id) in activeAnswers" :key="id">
                    <p id="answer">
                        {{ activeAnswer.answerText }}
                        <button :value="activeAnswer.id" onclick="alert(this.value)">Проголосовать</button>
                    </p>
                </li>
            </ul>
            <p v-show="initialVisible">
                <label>Добавить свой вариант ответа:</label><br />
                <input class="text" type="text" v-model="newAnswer" />
                <button @click="addAnswer(newAnswer)">Добавить</button>
            </p>
            <!--<h2>quastions № {{$route.params.id }}</h2>-->

        </div>        
    </section>
</template>

<script>
    export default {
        
        data() {
            return {
                newAnswer: "",
                activeQuestion: "",
                activeQuestionId: "",
                activeAnswers: "",
                initialVisible: false,
            }
        },      
        
            
        methods: {
            
            GetActiveQuestionsAnswer(value) {
                this.initialVisible = true;
                this.activeQuestionId = Number(value);
                fetch("https://localhost:44319/questions/" + value).then(response => response.json())
                    .then(commits => this.activeQuestion = commits);
                fetch("https://localhost:44319/answers/" + value).then(response => response.json())
                    .then(commits => this.activeAnswers = commits);
            },
            addAnswer(value) {
                fetch("https://localhost:44319/answers/",
                    {
                        method: 'POST',
                        headers: { "Accept": "application/json", "Content-Type": "application/json" },
                        body: JSON.stringify({ answerText: value, QuestionId: this.activeQuestionId })
                    });
                    fetch("https://localhost:44319/answers/" + this.activeQuestionId).then(response => response.json())
                    .then(commits => this.activeAnswers = commits);
               
            },
            
        }
    } 
</script>
<style>
    #answer {
        width: 30%;
        border: none;
        border-radius: 10px;
        margin: 10px;
        padding: 10px;
        background-color: silver;
    }

    #question {
        width: 40%;
        height: 30px;        
        border: none;        
        border-radius: 10px;
        margin: 20px;
        padding: 20px;
    }

    .radio-list {
        list-style: none;
    }
</style>

