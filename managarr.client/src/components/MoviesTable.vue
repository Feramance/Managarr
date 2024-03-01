<template>
    <div class="movie-component">
        <h1>Movies List</h1>

        <div v-if="loading" class="loading">
            Loading... Please refresh once the ASP.NET backend has started. See <a href="https://aka.ms/jspsintegrationvue">https://aka.ms/jspsintegrationvue</a> for more details.
        </div>

        <div v-if="post" class="content" style="overflow-x:auto">
            <table>
                <thead>
                    <tr>
                        <th style="text-align:center;">Title</th>
                        <th>Year</th>
                        <th>Monitored</th>
                        <th>HasFile</th>
                        <th>IsAvailable</th>
                        <th>isRequest</th>
                        <th>Searched</th>
                        <th>Upgrade</th>
                        <th>Instance</th>
                    </tr>
                </thead>
                <tbody>
                    <tr v-for="movie in post" :key="movie.id">
                        <td style="overflow-x:hidden; text-align:left;">{{ movie.title }}</td>
                        <td>{{ movie.year }}</td>
                        <td>
                            <div class="bool-mark">
                                <img v-if="movie.monitored" src="../assets/checkmark-64.png" />
                                <img v-else src="../assets/x-mark-64.png" />
                            </div>
                        </td>
                        <td>
                            <div class="bool-mark">
                                <img v-if="movie.hasFile" src="../assets/checkmark-64.png" />
                                <img v-else src="../assets/x-mark-64.png" />
                            </div>
                        </td>
                        <td>
                            <div class="bool-mark">
                                <img v-if="movie.isAvailable" src="../assets/checkmark-64.png" />
                                <img v-else src="../assets/x-mark-64.png" />
                            </div>
                        </td>
                        <td>
                            <div class="bool-mark">
                                <img v-if="movie.isRequest" src="../assets/checkmark-64.png" />
                                <img v-else src="../assets/x-mark-64.png" />
                            </div>
                        </td>
                        <td>
                            <div class="bool-mark">
                                <img v-if="movie.searched" src="../assets/checkmark-64.png" />
                                <img v-else src="../assets/x-mark-64.png" />
                            </div>
                        </td>
                        <td>
                            <div class="bool-mark">
                                <img v-if="movie.upgrade" src="../assets/checkmark-64.png" />
                                <img v-else src="../assets/x-mark-64.png" />
                            </div>
                        </td>
                        <td>{{ movie.instanceName }}</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</template>

<script lang="ts">
    import { defineComponent } from 'vue';

    type MovieFile = {
        movieFileId: number,
        qualityMet: boolean,
        customFormatMet: boolean,
        customFormatScore: number
    };

    type Movie = {
        hash: string,
        id: number,
        title: string,
        monitored: boolean,
        tmdbid: number,
        year: number,
        searched: boolean,
        isRequest: boolean,
        upgrade: boolean,
        isAvailable: boolean,
        hasFile: boolean,
        movieFiles: MovieFile[]
        instanceName: string,
    }[];

    interface Data {
        loading: boolean,
        post: null | Movie,
        interval: number
    }

    export default defineComponent({
        data(): Data {
            return {
                loading: false,
                post: null,
                interval: 0
            };
        },
        created() {
            // fetch the data when the view is created and the data is
            // already being observed
            //this.interval = setInterval(() => {
            //    this.fetchData()
            //}, 5000);
            this.fetchData();
        },
        watch: {
            // call again the method if the route changes
            '$route': 'fetchData'
        },
        methods: {
            fetchData(): void {
                this.post = null;
                this.loading = true;

                fetch('radarr/movies')
                    .then(r => r.json())
                    .then(json => {
                        this.post = json as Movie;
                        this.loading = false;
                        return;
                    });
            }
        },
        destroyed() {
            clearInterval(this.interval)
        }
    });
</script>

<style scoped>
th {
    font-weight: bold;
}

th, td {
    padding-left: .5rem;
    padding-right: .5rem;
    border-bottom: 1px solid;
    border-color: #ffffff;
    text-align: center;
}

.movie-component {
    text-align: center;
}

table {
    margin-left: 0;
    margin-right: 0;
    border-spacing: 0;
    width: 100%;
}

.bool-mark {
    width: 20px;
    height: 20px;
    box-sizing: content-box;
}

img {
    height: 14px;
}
</style>