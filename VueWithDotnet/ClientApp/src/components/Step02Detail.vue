<template>
  <div>
    <div style="margin-bottom: 20px">
      <el-button size="small" @click="goBack">{{ id }},返回</el-button>
    </div>
    <el-tabs v-model="activeName" @tab-click="handleClick">
      <el-tab-pane label="个人信息" name="first">个人信息</el-tab-pane>
      <el-tab-pane label="职业信息" name="second">职业信息</el-tab-pane>
    </el-tabs>
    <component :is="childComponent"></component>
  </div>
</template>
<script>
import user from "./components/Step02User.vue";
import Job from "./components/Step02Job.vue";

export default {
  name: "detail",
  components: {
    User,
    Job,
  },
  data() {
    return {
      activeName: "first",
      id: -1,
      childComponent: null,
    };
  },
  methods: {
    handleClick(tab, event) {
      console.log(tab, event);
    },
    goBack() {
      window.history.length > 1 ? this.$router.go(-1) : this.$router.push("/");
    },
  },
  mounted() {
    let self = this;
    self.id = this.$route.query.id;
  },
};
</script>
<style lang="">
</style>