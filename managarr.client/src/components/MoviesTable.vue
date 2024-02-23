<template>
    <div class="movie-component">
        <h1>Movies List</h1>

        <div v-if="loading" class="loading">
            Loading... Please refresh once the ASP.NET backend has started. See <a href="https://aka.ms/jspsintegrationvue">https://aka.ms/jspsintegrationvue</a> for more details.
        </div>

        <div v-if="post" class="content">
            <table>
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Title</th>
                        <th>Monitored</th>
                        <th>TmdbId</th>
                        <th>Year</th>
                        <th>Searched</th>
                        <th>IsRequest</th>
                        <th>Upgrade</th>
                        <th>IsAvailable</th>
                        <th>MovieFiles</th>
                        <th>Instance</th>
                    </tr>
                </thead>
                <tbody>
                    <tr v-for="movie in post" :key="movie.id">
                        <td>{{ movie.id }}</td>
                        <td>{{ movie.title }}</td>
                        <td>{{ movie.monitored }}</td>
                        <td>{{ movie.tmdbid }}</td>
                        <td>{{ movie.year }}</td>
                        <td>{{ movie.searched }}</td>
                        <td>{{ movie.isrequest }}</td>
                        <td>{{ movie.upgrade }}</td>
                        <td>{{ movie.isavailable }}</td>
                        <td>{{ movie.moviesfiles }}</td>
                        <td>{{ movie.instancename }}</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</template>

<script lang="ts">
    import { defineComponent } from 'vue';

    type MovieFile = {
        moviefileid: number,
        qualitymet: boolean,
        customformatmet: boolean,
        customformatscore: number
    };

    type Movie = {
        hash: string,
        id: number,
        title: string,
        monitored: boolean,
        tmdbid: number,
        year: number,
        searched: boolean,
        isrequest: boolean,
        upgrade: boolean,
        isavailable: boolean,
        instancename: string,
        moviefiles: MovieFile[]
    }[];

    interface Data {
        loading: boolean,
        post: null | Movie
    }

    export default defineComponent({
        data(): Data {
            return {
                loading: false,
                post: null
            };
        },
        created() {
            // fetch the data when the view is created and the data is
            // already being observed
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

                fetch('radarr')
                    .then(r => r.json())
                    .then(json => {
                        this.post = json as Movie;
                        this.loading = false;
                        return;
                    });
            }
        },
    });
</script>

<style scoped>
th {
    font-weight: bold;
}

tr:nth-child(even) {
    background: #4800ff;
}

tr:nth-child(odd) {
    background: #0094ff;
}

th, td {
    padding-left: .5rem;
    padding-right: .5rem;
}

.movie-component {
    text-align: center;
}

table {
    margin-left: auto;
    margin-right: auto;
    }
</style>