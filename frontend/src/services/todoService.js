import axios from 'axios';
const api = axios.create({ baseURL: 'http://localhost:5000/api/todo' });

export const getTodos = () => api.get('/');
export const addTodo = (todo) => api.post('/', todo);
