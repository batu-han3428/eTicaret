export const addProduct = ({title='', description='', dateAdded=0}) => ({
    type:"ADD_PRODUCT",
    urun:{
        title:title,
        description:description,
        dateAdded:dateAdded
    }
})


export const removeProduct = ({ id}:any) =>({
    type:"REMOVE_PRODUCT",
    id: id
})


export const editProduct = (id: any, updates: any)=>({
    type:"EDIT_PRODUCT",
    id,
    updates
})

export const listProducts = ({ location }: any) => ({
    type: "LİST_PRODUCTS",
    location:location
})