<template>
    <section>
        <div>

            <button @click="GetActiveQuestionsAnswer($route.params.id)">Загрузить вопрос и ответы </button>

            <h4 id="question">{{ activeQuestion.questionText }}</h4>
            <ul class="radio-list">
                <li v-for="(activeAnswer, id) in activeAnswers" :key="id">
                    <div id="answer">
                        {{ activeAnswer.answerText }}
                        <div v-show="visible">
                            <button :value="activeAnswer.id" @click="Voting">Проголосовать</button>
                            <abbr :title="activeAnswer.userVoice"> 👍 </abbr>
                            {{ activeAnswer.numberVoice }}
                        </div>

                    </div>
                </li>
            </ul>

            <p v-show="visible">

                <label>Добавить свой вариант ответа:</label><br />
                <input class="text" type="text" v-model="newAnswer" />
                <button @click="AddAnswer(newAnswer)">Добавить</button>
            </p>
            

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
                UserVoice: "",
                NumberUserVoice: "",
                visible: this.$parent.$data.UserSession,              
            }
        },      
        
        methods: {
            
            GetActiveQuestionsAnswer(value) {              
                this.activeQuestionId = Number(value);
                fetch("https://localhost:44319/questions/" + value).then(response => response.json())
                    .then(commits => this.activeQuestion = commits);
                fetch("https://localhost:44319/answers/" + value).then(response => response.json())
                    .then(commits => this.activeAnswers = commits);
                this.visible = this.$parent.$data.UserSession;
            },
            
            AddAnswer(value) {
                if (value != "") {
                    fetch("https://localhost:44319/answers/",
                        {
                            method: 'POST',
                            headers: { "Accept": "application/json", "Content-Type": "application/json" },
                            body: JSON.stringify({ answerText: value, QuestionId: this.activeQuestionId })
                        });
                    fetch("https://localhost:44319/answers/" + this.activeQuestionId).then(response => response.json())
                        .then(commits => this.activeAnswers = commits);
                    this.newAnswer = '';
                }
            },

            Voting(event) {

                
                fetch('https://localhost:44319/users/' + this.$parent.$data.UserSession)
                    .then(response => response.json())
                    .then(commits =>
                    {                        
                        fetch("https://localhost:44319/votes",
                            {
                                method: 'POST',
                                headers: { "Accept": "application/json", "Content-Type": "application/json" },
                                body: JSON.stringify({ answerId: Number(event.target.value), userName: commits.userName })
                            })
                    });
                
                fetch('https://localhost:44319/Votes/10/' + event.target.value).then(response => response.text()).then(number =>// numberUsers
                {
                    fetch('https://localhost:44319/votes/' + event.target.value).then(response => response.text()).then(users =>// Users
                    {                        
                        fetch("https://localhost:44319/answers",
                            {
                                method: 'PUT',
                                headers: { "Accept": "application/json", "Content-Type": "application/json" },
                                body: JSON.stringify({
                                    UserVoice: users,
                                    NumberVoice: Number(number),
                                    id: Number(event.target.value)
                                })
                            })

                    })
                });
                
                fetch("https://localhost:44319/answers/" + this.activeQuestionId).then(response => response.json())
                    .then(commits => this.activeAnswers = commits);
                
            },

           
        }
    } 
</script>
<style>
    #answer {
        width: 300px;
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

