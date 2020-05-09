import Vue from 'vue';
import VueRouter from 'vue-router';
import App from './App.vue';

Vue.config.productionTip = true;
Vue.use(VueRouter);

import Home from './components/Home.vue'
import Authorization from './components/Authorization.vue'
import Voting from './components/Voting.vue'


const routes = [
    { path: '/', component: Home },
    { path: '/logining', component: Authorization },
    { path: '/voting/:id', component: Voting, name: 'voting' },

];

const router = new VueRouter({
    mode: 'history',
    routes: routes
});

new Vue({
    router,
    render: h => h(App)
}).$mount('#app');
