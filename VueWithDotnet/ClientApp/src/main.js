import 'bootstrap/dist/css/bootstrap.css'
import axios from 'axios'
import { createApp } from 'vue'
import App from './App.vue'
import router from './router'

axios.defaults.headers.common["Access-Control-Allow-Origin"] = "*"
axios.defaults.baseURL = 'http://localhost:5000'
createApp(App).use(router).mount('#app')
