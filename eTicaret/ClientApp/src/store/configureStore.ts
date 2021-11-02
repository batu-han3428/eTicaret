/* eslint-disable import/no-anonymous-default-export */
import { createStore, combineReducers } from 'redux'
import urunReducer from '../reducers/urunler'
import kategoriReducer from '../reducers/kategoriler'


export default () => {
    const enhancers = [];
    const windowIfDefined = typeof window === 'undefined' ? null : window as any; // eslint-disable-line @typescript-eslint/no-explicit-any
    if (windowIfDefined && windowIfDefined.__REDUX_DEVTOOLS_EXTENSION__) {
        enhancers.push(windowIfDefined.__REDUX_DEVTOOLS_EXTENSION__());
    }

    const store = createStore(combineReducers({//combineReducers sayesinde store içerisine birden fazla reducers gönderebiliyoruz. yani iki farklý state i birleþtirdik. böylelikle bize ilk baþtaki gibi tek bir state oluþturuyor
        urunler: urunReducer,
        kategori: kategoriReducer
    }),
        ...enhancers);

    
    return store;
}