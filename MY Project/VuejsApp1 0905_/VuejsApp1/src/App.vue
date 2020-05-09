<template>
    <div>

        <h4 align="right" color="red" v-show="!UserSession">Вы еще не вошли на сайт</h4>
        <p align="right" v-show="!UserSession"><router-link to="/logining" tag="button">Ввойти</router-link></p>
        <h4 align="right" v-show="UserSession">Добро пожаловать: {{activeLoginUser}}</h4>
        <p align="right"><button v-show="UserSession" @click="()=> {UserSession = 0}">Выйти</button></p>
        <div class="container">
            <ul>
                <li><router-link to="/" exact>К списку вопросов</router-link></li>

            </ul>
            <slot></slot>
        </div>
        <router-view></router-view>
    </div>

   
</template>

<script>
   
    
    export default {
        name: 'app',
        data() {
            return {
                UserSession: 0,
                activeLoginUser: "",
            }
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
