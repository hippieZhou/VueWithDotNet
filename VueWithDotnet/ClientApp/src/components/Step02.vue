<template>
  <el-button @click="addRow">新增行</el-button>
  <el-table
    :data="tableData.filter((data) =>!search || data.name.toLowerCase().includes(search.toLowerCase()))" style="width: 100%">
    <el-table-column label="序号" prop="id"> </el-table-column>
    <el-table-column label="日期" prop="date"> </el-table-column>
    <el-table-column label="名称" prop="name"> </el-table-column>
    <el-table-column align="right">
      <template #header>
        <el-input v-model="search" size="mini" placeholder="输入关键字搜索" />
      </template>
      <template #default="scope">
        <el-button size="mini" @click="handleDetail(scope.$index, scope.row)">详情</el-button>
        <el-button size="mini" type="danger" @click="handleDelete(scope.$index, scope.row)">删除</el-button>
      </template>
    </el-table-column>
  </el-table>
</template>
<script>
export default {
  name: "Step02",
  data() {
    return {
      tableData: [],
      search: "",
    };
  },
  methods: {
    addRow() {
      let self = this;
      self.tableData.push({
        date: new Date().toLocaleString(),
        id: self.tableData.length,
        name: "王小虎" + self.tableData.length,
        address: "上海市普陀区金沙江路 1518 弄",
      });
    },
    handleDetail(index, row) {
      this.$router.push({path:'/step02/detail',query:{id:row.id}});
    },
    handleDelete(index, row) {
      let self = this;
      self.tableData.splice(index, 1);
      console.log(index, row);
    },
  },
};
</script>
<style lang="">
</style>