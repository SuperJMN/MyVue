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
            queryInterinos: function () {
                fetch('/api/Chorradia/People')
                    .then(response => response.json())
                    .then(json => this.people = json);
            }
        },      
    }
</script>
<style>
    
</style>
