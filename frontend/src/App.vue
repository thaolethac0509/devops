<template>
  <div>
    <h1>Todo List - {{ datetime }}</h1>
    <input v-model="newTodo" @keyup.enter="addNewTodo" />
    <ul>
      <li v-for="todo in todos" :key="todo.id">{{ todo.title }} </li>
    </ul>
  </div>
</template>

<script setup>
import { ref, onMounted } from 'vue';
import { getTodos, addTodo } from './services/todoService';

const todos = ref([]);
const newTodo = ref('');

const datetime = ref("")

const fetchTodos = async () => {
  datetime.value = Date.now()
  const res = await getTodos();
  todos.value = res.data;
  console.log("res",res)
};

const addNewTodo = async () => {
  await addTodo({ title: newTodo.value, isCompleted: false });
  newTodo.value = '';
  await fetchTodos();
};

onMounted(fetchTodos);
</script>
