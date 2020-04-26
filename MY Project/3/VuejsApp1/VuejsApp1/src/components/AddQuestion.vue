<template>
    <section>
        <p>
            <input type="text" @change="getQuestion" />
            <button @click="SendQuestion()">Добавить новый вопрос</button>
        </p>  
             
        <p>
            <input type="text" @change="getAnswer" />
            <button @click="SendAnswer()">Добавить вариант ответа</button>
        </p>       

    </section>
</template>
<script>
    export default {
        props: {           
            newQuestion: 'null',
            newAnswer: 'null'
        },
        methods: {
            SendQuestion() {
                this.$emit('Send-Question', this.newQuestion);
            },            
            getQuestion(event) {
                this.newQuestion = event.target.value;                
            },
            SendAnswer() {
                this.$emit('Send-Answer', this.newAnswer);
            },
            getAnswer(event) {
                this.newAnswer = event.target.value;
            }
        }


    } 
   
</script>