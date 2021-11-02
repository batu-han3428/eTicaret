const urunState: any[] = [];


const urunReducer = (state = urunState, action: any) => {
    console.log(action);
    switch (action.type) {
        case "ADD_BLOG":
            return [
                ...state,//dizinin önceki elemanlarını ekledik
                action.blog//diziye yeni eleman ekledik
            ]
        case "REMOVE_BLOG":
            return state.filter(({ id }) => {
                return id !== action.id;
            })
        case "EDIT_BLOG":
            return state.map((blog) => {
                if (blog.id === action.id) {
                    return {
                        ...blog,
                        ...action.updates
                    }
                } else {
                    return blog;
                }
            })
        case "LİST_PRODUCTS":
            return [
                action.location
            ]
        default:
            return state;
    }
};

export default urunReducer