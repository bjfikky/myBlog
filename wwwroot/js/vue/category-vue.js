﻿let modal = Vue.component('modal', {
    template: '#modal-template'
  })

new Vue ({
    el: '#category',

    components: {modal: modal},

    data: {
        showModal: false,
        
        categories: [
            {id : 1, name : 'C#'},
            {id : 2, name : 'Java'},
            {id : 3, name : 'PHP'},
            {id : 4, name : 'Python'},
            {id : 5, name : 'JavaScript'},
        ],

        
 
    },

    methods: {

    }
})
