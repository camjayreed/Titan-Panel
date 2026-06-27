<script>
import { createMemoryHistory, createRouter } from 'vue-router'
import Welcome from './pages/welcome.vue'
import Users from './pages/users.vue'

const routes = [
    { path: '/', component: Welcome },
    { path: '/users', component: Users },
]

export const router = createRouter({
    history: createMemoryHistory(),
    routes,
})
</script>

<template>
    <div class="sidebar">
        <div class="sidebar_items">
            <nav>
                <RouterLink to="/">Dashboard</RouterLink>
                <RouterLink to="/users">Users</RouterLink>
                <RouterLink to="/departments">Departments</RouterLink>
                <RouterLink to="/settings">Settings</RouterLink>
            </nav>
        </div>
        <div class="sidebarFooter">
            <p>© 2026 Titan Industries</p>
        </div>
    </div>
</template>

<style>
.sidebar {
    display: flex;
    flex-direction: column;

    width: 15rem;
    height: 92vh;

    border-right: 1px solid;
}

.sidebar_items {
    display: flex;
    flex-direction: column;

    flex: 1;
}

.sidebar_items a {
    display: flex;
    justify-content: center;
    align-items: center;

    height: 2.5rem;

    text-decoration: none;
    border-bottom: 1px solid;
}

.sidebarFooter {
    border-top: 1px solid;
    text-align: center;
}

</style>