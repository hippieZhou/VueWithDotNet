<template>
    <h1>学习级联</h1>
    <p>{{ msg }}</p>

    <select v-model="currentVal.provience" @change="chooseProvinces($event)">
        <option v-for="item of provinces" v-bind:key="item">{{ item }}</option>
    </select>
    <select v-model="currentVal.city" @change="chooiseCities($event)">
        <option v-for="item of cities" v-bind:key="item">{{ item }}</option>
    </select>
    <select v-model="currentVal.area">
        <option v-for="item of areas" v-bind:key="item">{{ item }}</option>
    </select>
    <br />
    <p>地址:{{ currentVal.provience }} - {{ currentVal.city }} - {{ currentVal.area }}</p>
</template>

<script>
    import axios from "axios";
    export default {
        name: "Step01",
        data() {
            return {
                msg: "202101 SP01",
                address: "未知地区",
                provinces: [],
                cities: [],
                areas: [],
                currentVal: {
                    provience: null,
                    city: null,
                    area: null
                }
            };
        },
        methods: {
            getProvinceList() {
                axios.get("/China/provinces").then((response) => {
                    this.provinces = response.data;
                });
            },
            chooseProvinces(event) {
                let province = event.target.value;
                axios.get("/China/cities", {
                    params: {
                        province: province,
                    },
                }).then((response) => {
                    this.cities = response.data;
                });
                this.currentVal.city = null;
                this.currentVal.area = null;
            },
            chooiseCities(event) {
                let city = event.target.value;
                axios.get('/china/areas', {
                    params: {
                        province: this.currentVal.provience,
                        city: city
                    }
                }).then((response) => {
                    this.areas = response.data;
                    console.log(response);
                }).catch(function (error) {
                    alert(error);
                });
                this.currentVal.area = null;
            },
        },
        watch: {
            address(val) {
                console.log(val);
            },
        },
        mounted() {
            this.getProvinceList();
        },
    };
</script>

<style scoped>
    select {
        width: 100px;
    }
</style>