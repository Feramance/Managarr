<script setup lang="ts">
    import MoviesTable from './components/MoviesTable.vue'
</script>

<template>
    <header>
        <img alt="Vue logo" class="logo" src="./assets/logo.svg" />
        <h1>Managarr</h1>
    </header>
    <section class="layout">
        <div class="sidebar">
            Sidebar
        </div>
        <div class="body">
            <div class="wrapper">
                <MoviesTable msg="You did it!" />
            </div>
        </div>
    </section>
</template>

<style scoped>
.layout {
    display: grid;
    grid: "sidebar body" 1fr / auto 1fr;
    gap: 8px;
    margin-top: 5%;
    margin-bottom: 0;
    width: 100%;
}

.sidebar {
    grid-area: sidebar;
    width: 15%;
    height: 95%;
    margin: 0;
    padding: 0;
}

.body {
    grid-area: body;
    width: 85%;
    height: 95%;
    margin: 0;
    padding: 0;
}

header {
    display:block;
  top: 0;
  width: 100%;
  height: max-content;
  max-height: 5%;
  position: fixed;
  padding: 10px 0;
}

.logo {
    left: 0;
    display: inline-block;
    width: 30px;
    height: auto;
}

h1 {
    display: inline-block;
    margin-left: 2%;
    text-align: center;
}
</style>
