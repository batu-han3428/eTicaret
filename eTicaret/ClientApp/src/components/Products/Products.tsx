import * as React from 'react';
import SiteHaritasi from './SiteHaritasi';
import Filtreleme from './Filtreleme';
import ProductKategoriler from './ProductKategoriler';
import Filtre from './Filtre';
import Marka from './Marka';
import Urunler from './Urunler';
import Pagination from './Pagination';
import './Products.css';
import { connect } from 'react-redux'
import { listProducts } from '../../action/urunler'
import configureStore from '../../store/configureStore';
import axios from 'axios'

const Products = (props:any) => {
    console.log(props.location.pathname);

    React.useEffect(() => {
        const store = configureStore();

        axios.post("https://localhost:5001/api/urunler/Index",props.location.pathname).then(res => {
            store.dispatch({
                type: "GET_USER",
                payload: res.data
            })
        });

    }, [])
    
    return (
        <div className="container-fluid" style={{ backgroundColor: "rgb(243, 243, 243)", paddingBottom: "25px" }}>
            <SiteHaritasi />
            <Filtreleme />
            <div className="container">
                <div className="row">
                    <ProductKategoriler />
                    <div className="col-md-9" id="filtreIcerik">
                        <Filtre />
                        <Marka />
                        <Urunler />
                        <Pagination />
                    </div>
                </div>
            </div>
        </div>
        )
}

const mapStateToProps = (state: any) => {
    return {
        urunler: state.urunler
    }
}

export default connect(mapStateToProps)(Products)