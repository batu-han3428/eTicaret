import * as React from 'react';

const Filtre = () => {
    return (
        <div className="row">
            <div className="col-md-12 p-4" id="icerikEnUst">
                <div className="me-auto">
                    <span><b>Telefon</b> için 2308 ürün bulundu</span>
                </div>
                <div id="filtreBuyukEkran">
                    <select className="form-select form-select-sm p-2">
                        <option disabled>Seçiniz...</option>
                        <option selected>En Popüler</option>
                        <option>İsme Göre (A-Z)</option>
                        <option>İsme Göre (Z-A)</option>
                        <option>Fiyata Göre (Artan)</option>
                        <option>Fiyata Göre (Azalan)</option>
                        <option>İndirimli Ürünler</option>
                    </select>
                </div>
            </div>
        </div>
        )
}

export default Filtre