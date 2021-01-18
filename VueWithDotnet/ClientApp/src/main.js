import axios from 'axios'
import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
import installElementPlus from './plugins/element'

axios.defaults.headers.common["Access-Control-Allow-Origin"] = "*"
axios.defaults.baseURL = 'http://localhost:5000'
const app = createApp(App)
installElementPlus(app)
app.use(router).mount('#app')