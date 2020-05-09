<template>
    <section>
        <div>
            <h1>Voting start!!!</h1>
            <h3>{{ activeQuestion.questionText }}</h3>
            <ul>
                <li v-for="(activeAnswer, id) in activeAnswers" :key="id">
                    <p>
                        {{ activeAnswer.answerText }}
                        <button :value="activeAnswer.id" onclick="alert(this.value)">Проголосовать</button>
                    </p>
                </li>
            </ul>
            
        </div>        
    </section>
</template>

<script>
    export default {
        props: {
            activeQuestion: "",
            activeAnswers:""
        },
        methods: {
            
        }
    } 
</script>

