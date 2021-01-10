import { createWebHistory, createRouter } from "vue-router";
import Home from "@/components/Home.vue";
import Step01 from "@/components/Step01.vue";

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
    }
];

const router = createRouter({
    history: createWebHistory(),
    routes,
});

export default router;