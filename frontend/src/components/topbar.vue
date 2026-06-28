<template>
    <div class="topbar">
        <p>Current User:</p>
        <p id="top_title">Titan Panel</p>
        <a href="" id="top_login">Login</a>
    </div>
</template>

<style scoped>
.topbar {
    display: flex;
    justify-content: space-between;
    align-items: center;
    border-bottom: 1px solid;
    padding: 0 10px;
    height: 7vh;
}

.topbar p,
.topbar a {
    margin: 0;
}

#top_login {
    border-style: none;
}
</style>