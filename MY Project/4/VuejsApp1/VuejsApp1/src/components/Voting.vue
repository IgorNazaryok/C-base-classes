<template>
    <section>
        <div>
            <h4>{{ activeQuestion.questionText }}</h4>
            <ul class="radio-list">
                <li v-for="(activeAnswer, id) in activeAnswers" :key="id">
                    <p id="block1">
                        {{ activeAnswer.answerText }}
                        <button :value="activeAnswer.id" onclick="alert(this.value)">Проголосовать</button>
                    </p>
                </li>
            </ul>
            <p v-show="initialVisible">
                <label>Добавить свой вариант:</label><br />
                <input class="text" type="text" v-model="newAnswer" />
                <button @click="SendAnswer()">Добавить</button>
            </p>

        </div>        
    </section>
</template>

<script>
    export default {
        
        data() {
            return {
                newAnswer: "",               
            }
        },
        props: ['activeQuestion', 'activeAnswers', 'initialVisible'],
        
            
        methods: {
            SendAnswer() {
                this.$emit('Send-Answer', this.newAnswer);

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

