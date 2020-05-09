import QuestionList from './components/QuestionList.vue';
import AddQuestion from './components/AddQuestion.vue';
import Authorization from './components/Authorization.vue';

export default {
    '/ ': QuestionList,
    '/addQuestion': AddQuestion,
    '/logining': Authorization,
    components: {
        QuestionList,
        AddQuestion,
        Authorization
    },
}