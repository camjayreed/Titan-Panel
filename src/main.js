import { createApp } from "vue";
import App from "./App.vue";
import { router } from "./components/sidebar.vue";

createApp(App).use(router).mount("#app");
