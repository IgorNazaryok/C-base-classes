<template>
    <section>        
        <div id="block">
            <h3>Вход на сайт</h3>
            <label>Введите логин *</label><br />
            <input class="text" type="text" placeholder="Логин" v-model="login" /> <br /><br />
            <label>Введите пароль *</label><br />
            <input class="text" type="password" placeholder="Пароль" v-model="password" /><br /><br />
            <button @click="Authorization()">Ввойти</button>
            <button @click="()=> {this.$parent.$data.UserSession = 0}">Выйти</button>
        </div>

        <div id="block">
            <h3>Регистрация на сайте</h3>
                <label>Введите логин *</label><br />
                <input class="text" type="text" placeholder="Не мененее 3 символов" v-model="newLogin" /> <br /><br />

            <label>Введите пароль *</label><br />
            <input class="text" type="password" placeholder="Не мененее 6 символов" v-model="newPassword" /><br /><br />
            <button @click="Registration()">Регистрация</button>
            
        </div>
        
    </section>
</template>

<script>    
    export default {
        
        data() {
            return {
                login: "",
                password: "",
                newLogin: "",
                newPassword: "",
                
            }
        },
        methods: {
            Authorization() {             
                             
                fetch("https://localhost:44319/users" + "/" + this.login + "/" + this.password).
                    then(response => response.text()).then(commits =>
                    {                        
                        if (commits == '0') {
                            alert("Такой пользователь не найден! Повторите ввод или пройдите регистрацию");
                            this.login = this.password="";
                        }
                        else
                        {                            
                            
                            this.$parent.$data.UserSession = Number(commits);
                            this.$parent.$data.activeLoginUser = this.login;
                            this.login = this.password = "";                            
                           
                        }
                    })                 
                    
                
            },

            Registration() {
                
                if ((this.newLogin.length >= 3) && (this.newPassword.length >= 6))
                {
                    fetch(this.urlU,
                        {
                            method: 'POST',
                            headers: { "Accept": "application/json", "Content-Type": "application/json" },
                            body: JSON.stringify({ UserName: this.newLogin, password: this.newPassword })
                        })
                        .then(response => response.text())
                        .then(data => {
                            if (data != '0')
                            {
                                alert("Спасибо за регистрацию " + this.newLogin + "! Теперь Вы можете ввойти на наш сайт.");
                                this.newLogin = this.newPassword = "";
                            }
                            else
                            {
                                alert("Уже существует пользователь с таким логином, выберите другой");
                                this.newLogin = this.newPassword = "";
                            }
                        })
                }
                else
                {
                    alert("Длина логина или пароля не соответствует требованиям безопасности");
                    this.newLogin = this.newPassword = "";
                }   
            },
        }
    } 
</script>

<style scoped>
    #block {
        float: left;
        display: block;
        width: 300px;
        border: 1px solid gray;
        border-radius: 10px;
        margin: 20px;
        padding: 10px;
        background-color: silver;
    }
    input.text {
        width: 200px;
        height: 15px;
        padding: 5px 10px 5px 10px;
        border-radius: 5px;
    }

</style>