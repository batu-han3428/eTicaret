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

    const store = createStore(combineReducers({//combineReducers sayesinde store i�erisine birden fazla reducers g�nderebiliyoruz. yani iki farkl� state i birle�tirdik. b�ylelikle bize ilk ba�taki gibi tek bir state olu�turuyor
        urunler: urunReducer,
        kategori: kategoriReducer
    }),
        ...enhancers);

    
    return store;
}