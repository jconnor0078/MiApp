(function() {
    $(function() {
        $('#UserTableContainer').jtable({
            title: 'Table of user',
            actions: {
                listAction: '/Users/GetUserList/',
                //createAction: '/GettingStarted/CreatePerson',
                //updateAction: '/GettingStarted/UpdatePerson',
                //deleteAction: '/GettingStarted/DeletePerson'
            },
            fields: {
               
                Name: {
                    title: 'Author Name',
                    width: '40%'
                },
                UserName: {
                    title: 'nombre de usuario',
                    width: '40%'
                },
                FullName: {
                    title: 'nombre full',
                    width: '40%'
                }//,
                //RecordDate: {
                //    title: 'Record date',
                //    width: '30%',
                //    type: 'date',
                //    create: false,
                //    edit: false
                //}
            }
        });
        //Load person list from server
        $('#PersonTable').jtable('load');

        var _userService = abp.services.app.user;
        var _$modal = $('#UserCreateModal');
        var _$form = _$modal.find('form');

        _$form.validate();

        _$form.find('button[type="submit"]').click(function (e) {
            e.preventDefault();

            if (!_$form.valid()) {
                return;
            }

            var user = _$form.serializeFormToObject(); //serializeFormToObject is defined in main.js
            
            abp.ui.setBusy(_$modal);
            _userService.createUser(user).done(function () {
                _$modal.modal('hide');
                location.reload(true); //reload page to see new user!
            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });
        });
        
        _$modal.on('shown.bs.modal', function () {
            _$modal.find('input:not([type=hidden]):first').focus();
        });




    });

})();