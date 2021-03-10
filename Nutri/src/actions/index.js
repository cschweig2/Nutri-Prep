import * as c from './ActionTypes';

export const toggleMal = () => ({
    type: c.TOGGLE_MAL
});

export const toggleDetails = () => ({
    type: c.TOGGLE_DETAILS
});

export const toggleSuppList = () => ({
    type: c.TOGGLE_SUPP_LIST
});

export const requestSupplements = () => ({
    type: c.REQUEST_SUPP
});

export const getSuppSuccess = (suppData) => ({
    type: c.GET_SUPP_SUCCESS,
    suppData
});

export const getSuppFailure = (error) => ({
    type: c.GET_SUPP_FAILURE,
    error
});

export const getMalady = (maladyName) => ({
    type: c.DISPLAY_MAL,
    maladyName
})

export const makeApiCall = (maladyType) => {
    return dispatch => {
        dispatch(requestSupplements);
        return fetch(`http://localhost:5000/api/supplements/?maladies=${maladyType}`) // ${malady} to search by malady clicked by user
            .then(response => response.json())
            .then(
                (jsonifiedResponse) => {
                    dispatch(getSuppSuccess(jsonifiedResponse));
                    dispatch(requestSupplements);
                })
            .catch((error) => {
                dispatch(getSuppFailure(error));
                dispatch(requestSupplements);
            });
    }
}