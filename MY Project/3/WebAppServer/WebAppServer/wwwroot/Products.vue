<template>
    <div id="app1">        
        <ul>
            <li v-for= "message in messages" >
            <p>{{ message.questionText }} <button v-on:click="">Голосовать</button></p>


            </li >
        </ul> <br><br>
        <p>
            <input type="text" v-model="newQuestionText" />
            <button v-on:click="CreateQ('/questions')">Создать новый вопрос</button>
        </p>
        <p>
            <input type="text" v-model="newAnswers" />
            <button v-on:click="CreateA('/answers')">Добавить вариант ответа</button>
        </p>
        <p>
            {{ QuestionId }}

            {{ Get('/questions') }}
        </p>

    </div> 
</template>
<script>
    var app1 = new Vue({
        el: '#app1',
        data: {
            messages: "test",
            newQuestionText: '',
            QuestionId: 'пусто',
            newAnswers: ''

        },
        methods:
        {
            Get: function (url) {
                fetch(url).then(response => response.json())
                    .then(commits => this.messages = commits);
            },
            //--------------------------------------------
            CreateQ: function (url) {
                fetch(url,
                    {
                        method: 'POST',
                        headers: { "Accept": "application/json", "Content-Type": "application/json" },
                        body: JSON.stringify({ questionText: this.newQuestionText })
                    })
                    .then(response => response.json())
                    .then(data => this.QuestionId = data.id);
            },
            //--------------------------------------------
            CreateA: function (url) {
                fetch(url,
                    {
                        method: 'POST',
                        headers: { "Accept": "application/json", "Content-Type": "application/json" },
                        body: JSON.stringify({ answerText: this.newAnswers, QuestionId: this.QuestionId })
                    })

                //.then(response => response.ok === true ? console.log("записано") : console.log("не записано"));
            }
            //--------------------------------------------

        }
    });
</script>