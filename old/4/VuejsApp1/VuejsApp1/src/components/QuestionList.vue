<template>
    <section>
        <div>

            <button @click="Get('https://localhost:44319/questions')">Загрузить список вопросов </button>
            <ul class="radio-list">
                <li v-for="(question, id) in questions" :key="id">
                    <p id="link">
                     <router-link :to="{name: 'voting', params:{id:question.id}}">{{ question.questionText }}</router-link>
                    </p>
                </li>
            </ul>            
            
        </div>
       
        

    </section>
</template>
<script>    
   
 
    export default {
        props:[],
            
        data() {
            return {           
                urlA: 'https://localhost:44319/answers',
                questions:"",
            }
        },
        components: {
                    
        },
        methods: {
            Get(url) {
                fetch(url).then(response => response.json()).then(commits => this.questions = commits);
            }, 
        }
    }

</script>
<style>
    #link {
        
        width: 30%;
        
        border: 1px solid gray;
        border-radius: 10px;
        margin: 10px;
        padding: 10px;
        background-color: silver;
    }
   
    .radio-list {
        list-style: none;
    }
</style>