<template>
    <div>
        <h1>Weather forecast</h1>
        <p>This component demonstrates fetching data from the server.</p>
        <p v-if="!people"><em>Pulse el botoncejo para cargar</em></p>
        <button @click="queryInterinos()">Cargar</button>
        <table class="table" v-if="people">
            <thead>
                <tr>
                    <th>Date</th>
                    <th>Temp. (C)</th>
                    <th>Temp. (F)</th>
                    <th>Summary</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="person in people">
                    <td>{{ person.firstName }}</td>
                    <td>{{ person.lastName }}</td>
                </tr>
            </tbody>
        </table>

    </div>
</template>
<script>

    export default {
        data() {
            return {
                people: null,
            }
        },

        methods: {
            //queryInterinos: async function () {
            //    let response = await this.$http.get(queryInterinos: async function () {
            //    let response = await this.$http.get('/api/Chorradia/People')
            //    console.log(response.data);
            //    this.people = response.data;
            //})
            //    console.log(response.data);
            //    this.people = response.data;
            //}

            queryInterinos: function () {
                fetch('/api/Chorradia/People')
                    .then(response => response.json())
                    .then(json => this.people = json);
            }
        },

        //async created() {
        //    // ES2017 async/await syntax via babel-plugin-transform-async-to-generator
        //    // TypeScript can also transpile async/await down to ES5
        //    try {
        //        let response = await this.$http.get('/api/SampleData/WeatherForecasts')
        //        console.log(response.data);
        //        this.forecasts = response.data;
        //    } catch (error) {
        //        console.log(error)
        //    }

        //    try {
        //        let response = await this.$http.get('/api/Chorradia/People')
        //        console.log(response.data);
        //        this.people = response.data;
        //    } catch (error) {
        //        console.log(error)
        //    }
        //    // Old promise-based approach
        //    //this.$http
        //    //    .get('/api/SampleData/WeatherForecasts')
        //    //    .then(response => {
        //    //        console.log(response.data)
        //    //        this.forecasts = response.data
        //    //    })
        //    //    .catch((error) => console.log(error))*/
        //}
    }
</script>
<style>
    
</style>
