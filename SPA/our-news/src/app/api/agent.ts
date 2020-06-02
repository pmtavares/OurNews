import axios, { AxiosResponse } from 'axios';
import { IArticle } from '../models/article';

axios.defaults.baseURL = "http://localhost:5000/api";


const responseBody = (response: AxiosResponse) => response.data;


const requests = {
    get: (url: string) => axios.get(url).then(responseBody),
    post: (url: string, body:{}) => axios.post(url, body).then(responseBody),
    put: (url: string, body: {}) => axios.put(url, body).then(responseBody),
    del: (url: string) => axios.delete(url).then(responseBody)
}


const Articles = {
    listLatest: ()=>  requests.get("/articles/latest"),
    details: (id: string) => requests.get(`/articles/${id}`),
    create: (article: IArticle) => requests.post("/articles/", article),
    update: (article: IArticle) => requests.put(`/articles/${article.id}`, article),
    delete: (id: string) => requests.del(`/articles/${id}`),
    frontArticles: () => requests.get("/articles/frontnews")
}

export default 
{
    Articles
}