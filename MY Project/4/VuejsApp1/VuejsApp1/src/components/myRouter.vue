<template>
    <div id="app">
        <div class="container">
            <ul>
                <li><router-link to="/" exact>QuestionList</router-link></li>
                <li><router-link to="/logining">Authorization</router-link></li>
                <li><router-link to="/voting">Voting</router-link></li>
                
            </ul>
            <slot></slot>
        </div>
        <router-view></router-view>
    </div>
</template>

<script>
    import Home from './Home.vue'    
    import Authorization from './Authorization.vue'
    import Voting from './Voting.vue'
    import VueRouter from 'vue-router';
    const routes = [
        { path: '/', component: Home },        
        { path: '/voting', component: Voting },
        { path: '/logining', component: Authorization }
    ];
    
    const router = new VueRouter({
        mode: 'history',
        routes: routes
    });
  
    export default {
        components: {
            Home,
            Voting,
            Authorization
        },
        router: router
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