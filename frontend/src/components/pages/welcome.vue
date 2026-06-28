<script setup>
import { ref } from 'vue'

    let count = ref(0)
    async function hello() {
        const response = await fetch("http://localhost:5117/hello");
        console.log(response)
    }
</script>

<template>
    <p>Welcome</p>
    <p>User</p>
    <button @click="count++, hello()">Hello Backend!</button>
    <p>Times said hello: {{ count }}</p>
</template>