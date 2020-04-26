<template>
    <section>
        <div>
            {{Get('https://localhost:44319/questions')}}
            <ul>
                <li v-for="(question, id) in questions" :key="id">
                    <p>
                        {{ question.questionText }}
                        <button :value="question.id" @click="GetActiveQuestionsAnswer">Открыть</button>

                    </p>
                </li>
            </ul>
            <br><br>            
            <Voting :active-Question="activeQuestion" :active-Answers="activeAnswers" />
        </div>
       
        

    </section>
</template>
<script>
    import Voting from './Voting.vue';
   
    
    export default {
        props: {
            questions: "",
            activeQuestion:"hello",
            activeAnswers: ""          
        },
        components: {            
            Voting,            
        },
        methods: {
           
            Get(url) {
                fetch(url).then(response => response.json())
                    .then(commits => this.questions = commits);
            },
            GetActiveQuestionsAnswer(event) {
                alert("https://localhost:44319/questions/" + event.target.value);
                fetch("https://localhost:44319/questions/" + event.target.value).then(response => response.json())
                    .then(commits => this.ActiveQuestion = commits);
                fetch("https://localhost:44319/answers/" + event.target.value).then(response => response.json())
                    .then(commits => this.ActiveAnswers = commits);
            }
        }
    } 
   
</script>