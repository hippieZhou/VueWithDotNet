import { createWebHistory, createRouter } from "vue-router";
import Home from "@/components/Home.vue";
import Step01 from "@/components/Step01.vue";
import Step02 from "@/components/Step02.vue";
import Step02Detail from '@/components/Step02Detail'

const routes = [
    {
        path: "/",
        name: "Home",
        component: Home,
    },
    {
        path: "/Step01",
        name: "Step01",
        component: Step01,
    }, {
        path: '/Step02',
        name: 'Step02',
        component: Step02,
    }, {
        path: '/step02/detail',
        name: 'Detail',
        props: true,
        component: Step02Detail,
    }
];

const router = createRouter({
    history: createWebHistory(),
    routes,
});

export default router;