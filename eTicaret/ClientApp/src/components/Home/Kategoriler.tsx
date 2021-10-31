import * as React from 'react';
import * as Icon from 'react-bootstrap-icons';

const Kategoriler = () => {
    return (
            <>
            <div className="row p-2 border-bottom " style={{borderColor: "rgb(180, 176, 176) !important"}}>
                <div className="col-md-12">
                    <span className="display-6 text-muted">Kategoriler</span>
                </div>
            </div>
            <div className="row">
                <div className="col-md-12" style={{ textAlign: "center" }}>

                    {/*Kategoriler Md ve Yukarısı*/}
                    <div id="benimSliderım">
                        <div className="TusDiv">
                            <span id="geriKategori"><Icon.ArrowBarLeft /></span>
                        </div>
                        <div id="sliderIc">
                            <div className="topAlan">
                                <div className="topAlanDiv">
                                    <div className="top" onClick={() => window.location.href = '#'}>
                                        <Icon.PhoneVibrate className="kategoriIkon" />                                       
                                    </div>
                                    <div className="yazi">
                                        <a href="#"><span>Cep Telefonları</span></a>
                                    </div>
                                </div>
                            </div>
                            <div className="topAlan">
                                <div className="topAlanDiv">
                                    <div className="top" onClick={() => window.location.href = '#'}>
                                        <Icon.Tv className="kategoriIkon" />
                                    </div>
                                    <div className="yazi">

                                        <a href="#"><span>Televizyonlar</span></a>
                                    </div>
                                </div>
                            </div>
                            <div className="topAlan">
                                <div className="topAlanDiv">
                                    <div className="top" onClick={() => window.location.href = '#'}>
                                        <Icon.Laptop className="kategoriIkon" />
                                    </div>
                                    <div className="yazi">

                                        <a href="#"><span>Notebook'lar</span></a>
                                    </div>
                                </div>
                            </div>
                            <div className="topAlan">
                                <div className="topAlanDiv">
                                    <div className="top" onClick={() => window.location.href = '#'}>
                                        <Icon.House className="kategoriIkon" />
                                    </div>
                                    <div className="yazi">

                                        <a href="#"><span>Beyaz Eşya</span></a>
                                    </div>
                                </div>
                            </div>
                            <div className="topAlan">
                                <div className="topAlanDiv">
                                    <div className="top" onClick={() => window.location.href = '#'}>
                                        <Icon.Hammer className="kategoriIkon" />
                                    </div>
                                    <div className="yazi">

                                        <a href="#"><span>Elektrikli Ev Aletleri</span></a>
                                    </div>
                                </div>
                            </div>
                            <div className="topAlan">
                                <div className="topAlanDiv">
                                    <div className="top" onClick={()=>window.location.href='#'}>
                                        <Icon.Heart className="kategoriIkon" />
                                    </div>
                                    <div className="yazi">

                                        <a href="#"><span>Kişisel Bakım</span></a>
                                    </div>
                                </div>
                            </div>
                            <div className="topAlan">
                                <div className="topAlanDiv">
                                    <div className="top" onClick={()=>window.location.href='#'}>
                                        <Icon.Controller className="kategoriIkon" />
                                    </div>
                                    <div className="yazi">

                                        <a href="#"><span>Oyun Konsolları</span></a>
                                    </div>
                                </div>
                            </div>
                            <div className="topAlan">
                                <div className="topAlanDiv">
                                    <div className="top" onClick={()=>window.location.href='#'}>
                                        <Icon.Camera className="kategoriIkon" />
                                    </div>
                                    <div className="yazi">

                                        <a href="#"><span>Fotoğraf Makineleri</span></a>
                                    </div>
                                </div>
                            </div>
                            <div className="topAlan">
                                <div className="topAlanDiv">
                                    <div className="top" onClick={()=>window.location.href='#'}>
                                        <Icon.Smartwatch className="kategoriIkon" />
                                    </div>
                                    <div className="yazi">

                                        <a href="#"><span>Aksesuar</span></a>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div className="TusDiv">
                            <span id="ileriKategori"><Icon.ArrowBarRight /></span>
                        </div>
                    </div>
                   {/* /Kategoriler Md ve Yukarısı */}

                     {/*Kategoriler Mobil */}
                    <div id="benimSliderımMobil">
                        <div className="TusDivMobil">
                            <span id="geriKategoriMobil"><Icon.ArrowBarLeft /></span>
                        </div>



                        <div id="sliderIcMobil">

                            <div className="topAlanMobil">
                                <div className="topAlanDivMobil">
                                    <div className="topMobil" onClick={() => window.location.href = '#'}>
                                        <Icon.PhoneVibrate className="kategoriIkonMobil" />
                                    </div>
                                    <div className="yaziMobil">
                                        <a href="#"><span>Cep Telefonları</span></a>
                                    </div>

                                </div>
                            </div>
                            <div className="topAlanMobil">
                                <div className="topAlanDivMobil">
                                    <div className="topMobil" onClick={() => window.location.href = '#'}>
                                        <Icon.Tv className="kategoriIkonMobil" />
                                    </div>
                                    <div className="yaziMobil">

                                        <a href="#"><span>Televizyonlar</span></a>
                                    </div>
                                </div>
                            </div>
                            <div className="topAlanMobil">
                                <div className="topAlanDivMobil">
                                    <div className="topMobil" onClick={() => window.location.href = '#'}>
                                        <Icon.Laptop className="kategoriIkonMobil" />
                                    </div>
                                    <div className="yaziMobil">

                                        <a href="#"><span>Notebook'lar</span></a>
                                    </div>
                                </div>
                            </div>
                            <div className="topAlanMobil">
                                <div className="topAlanDivMobil">
                                    <div className="topMobil" onClick={() => window.location.href = '#'}>
                                        <Icon.House className="kategoriIkonMobil" />
                                    </div>
                                    <div className="yaziMobil">

                                        <a href="#"><span>Beyaz Eşya</span></a>
                                    </div>
                                </div>
                            </div>
                            <div className="topAlanMobil">
                                <div className="topAlanDivMobil">
                                    <div className="topMobil" onClick={() => window.location.href = '#'}>
                                        <Icon.Hammer className="kategoriIkonMobil" />
                                    </div>
                                    <div className="yaziMobil">

                                        <a href="#"><span>Elektrikli Ev Aletleri</span></a>
                                    </div>
                                </div>
                            </div>
                            <div className="topAlanMobil">
                                <div className="topAlanDivMobil">
                                    <div className="topMobil" onClick={()=>window.location.href='#'}>
                                        <Icon.Heart className="kategoriIkonMobil" />
                                    </div>
                                    <div className="yaziMobil">

                                        <a href="#"><span>Kişisel Bakım</span></a>
                                    </div>
                                </div>
                            </div>
                            <div className="topAlanMobil">
                                <div className="topAlanDivMobil">
                                    <div className="topMobil" onClick={()=>window.location.href='#'}>
                                        <Icon.Controller className="kategoriIkonMobil" />
                                    </div>
                                    <div className="yaziMobil">

                                        <a href="#"><span>Oyun Konsolları</span></a>
                                    </div>
                                </div>
                            </div>
                            <div className="topAlanMobil">
                                <div className="topAlanDivMobil">
                                    <div className="topMobil" onClick={()=>window.location.href='#'}>
                                        <Icon.Camera className="kategoriIkonMobil" />
                                    </div>
                                    <div className="yaziMobil">

                                        <a href="#"><span>Fotoğraf Makineleri</span></a>
                                    </div>
                                </div>
                            </div>
                            <div className="topAlanMobil">
                                <div className="topAlanDivMobil">
                                    <div className="topMobil" onClick={() => window.location.href = '#'}>
                                        <Icon.Smartwatch className="kategoriIkonMobil" />
                                    </div>
                                    <div className="yaziMobil">

                                        <a href="#"><span>Aksesuar</span></a>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div className="TusDivMobil">
                            <span id="ileriKategoriMobil"><Icon.ArrowBarRight /></span>
                        </div>
                    </div>
                    {/*/Kategoriler Mobil */}

                </div>
            </div>
            </>
        )
}

export default Kategoriler