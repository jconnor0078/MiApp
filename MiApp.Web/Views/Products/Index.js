(function() {
    $(function() {

        var _productService = abp.services.app.product;
        var _$modal = $('#ProductCreateModal');
        var _$form = _$modal.find('form');

        _$form.validate();

        _$form.find('button[type="submit"]').click(function (e) {
            e.preventDefault();

            if (!_$form.valid()) {
                return;
            }

            var product = _$form.serializeFormToObject(); //serializeFormToObject is defined in main.js
            
            abp.ui.setBusy(_$modal);
            _productService.createProduct(product).done(function () {
                _$modal.modal('hide');
                location.reload(true); //reload page to see new product!
            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });
        });
        
        _$modal.on('shown.bs.modal', function () {
            _$modal.find('input:not([type=hidden]):first').focus();
        });
    });
})();