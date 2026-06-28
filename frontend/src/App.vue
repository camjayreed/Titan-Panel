<script setup>
import Topbar from './components/topbar.vue'
import Sidebar from './components/sidebar.vue'
</script>


<template>
  <section class="topbar">
    <Topbar/>
  </section>

  <section class="sidebar">
    <Sidebar/>
  </section>

  <section class="contentWindow">
    <router-view />
  </section>
</template>


<style>
#app {
    display: grid;
    grid-template-columns: 15rem 1fr;
    grid-template-rows: 60px 1fr;
    height: 100vh;
}

.topbar {
    grid-column: 1 / 3;
    grid-row: 1;
}

.sidebar {
    grid-column: 1;
    grid-row: 2;
}

.contentWindow {
    flex: 1;
    padding: 1rem;
    overflow: auto;

    grid-column: 2;
    grid-row: 2;
}
</style>