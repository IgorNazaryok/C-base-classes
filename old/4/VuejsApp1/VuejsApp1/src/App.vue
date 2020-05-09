<template>
   
    <Router/>
</template>

<script>
    import Router from './components/myRouter.vue'
    
    export default {
        name: 'app',
        data() {
            return {
                questions: "",
                QuestionId: "",
                urlQ: 'https://localhost:44319/questions',
                urlA: 'https://localhost:44319/answers',
                UserSession: "",

            }
        },        
        components: {
           Router
        },
        
    }
</script>
<style scoped>
    .container {
        max-width: 600px;
        margin: 0 auto;
        padding: 15px 30px;
        background: #f9f7f5;
    }
    ul {
        list-style-type: none;
        padding: 0;
    }

    li {
        display: inline-block;
    }
    a {
        padding: 10px;
    }
        
</style>
