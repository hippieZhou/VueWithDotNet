<template>
  <div>
    <div style="margin-bottom: 20px">
      <el-button size="small" @click="goBack">{{ id }},返回</el-button>
      <el-button size="small" @click="toggle">切换</el-button>
    </div>
    <component :is="childComponent"></component>
  </div>
</template>
<script>
import User from "./Step02User";
import Job from "./Step02Job";
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
      childComponent: 'User',
    };
  },
  methods: {
    handleClick(tab, event) {
      console.log(tab, event);
    },
    goBack() {
      window.history.length > 1 ? this.$router.go(-1) : this.$router.push("/");
    },
    toggle(){
      this.childComponent = this.childComponent === 'User'?'Job':'User';
    }
  },
  mounted() {
    let self = this;
    self.id = this.$route.query.id;
  },
};
</script>
<style lang="">
</style>