<template>
    <div>
        <h1>Mi ejemplillo</h1>
        <p>This component demonstrates fetching data from the server.</p>
        <p v-if="!people"><em>Pulse el botoncejo para cargar los datos desde el backend</em></p>
        <button @click="retrieveData()">Cargar</button>
        <table class="table" v-if="people">
            <thead>
                <tr>
                    <th>Nombre</th>
                    <th>Apellido</th>
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
            retrieveData: function () {
                fetch('/api/Ejemplo/People')
                    .then(response => response.json())
                    .then(json => this.people = json);
            }
        },      
    }
</script>
<style>
    
</style>
