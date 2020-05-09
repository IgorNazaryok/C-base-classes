<template>
    <section>
        <p>
            <label>Добавить свой вопрос: </label><br />
            <input class="text" type="text" v-model="newQuestion" />
            <button @click="SendQuestion()">Добавить</button>
        </p>  
             
        <p>
            <label>Добавить ответ к своему вопросу:</label><br />
            <input class="text" type="text" v-model="newAnswer" />
            <button @click="SendAnswer()">Добавить</button>
        </p>       

    </section>
</template>
<script>
  
    export default {
        components: {
           
        },
        props: ['newQuestion', 'newAnswer'],
        methods: {
            SendQuestion() {
                this.$emit('Send-Question', this.newQuestion);
            },  
            SendAnswer() {
                this.$emit('Send-Answer', this.newAnswer);                
            },
            
        }
    } 
   
</script>
<style scoped>
    input.text {
        width: 300px;
        height: 30px;
        padding: 5px 10px 5px 10px;
        border-radius: 5px;
        margin-right: 15px;
    }
</style>