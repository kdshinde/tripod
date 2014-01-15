'use strict';
var App;
(function (App) {
    (function (Directives) {
        (function (PopoverToggle) {
            PopoverToggle.directiveName = 'popover';

            PopoverToggle.directiveConfig = [
                '$tooltipProvider', function ($tooltipProvider) {
                    $tooltipProvider.setTriggers({
                        'show-popover': 'hide-popover'
                    });
                }];

            var directiveFactory = function () {
                return [
                    '$timeout', function ($timeout) {
                        var directive = {
                            name: PopoverToggle.directiveName,
                            restrict: 'A',
                            link: function (scope, element, attr) {
                                attr[PopoverToggle.directiveName + 'Trigger'] = 'show-popover';

                                var redrawPromise;
                                $(window).on('resize', function () {
                                    if (redrawPromise)
                                        $timeout.cancel(redrawPromise);
                                    redrawPromise = $timeout(function () {
                                        if (!scope['tt_isOpen'])
                                            return;
                                        element.triggerHandler('hide-popover');
                                        element.triggerHandler('show-popover');
                                    }, 100);
                                });

                                scope.$watch(attr[PopoverToggle.directiveName + 'Toggle'], function (value) {
                                    if (value && !scope['tt_isOpen']) {
                                        $timeout(function () {
                                            element.triggerHandler('show-popover');
                                        });
                                    } else if (!value && scope['tt_isOpen']) {
                                        $timeout(function () {
                                            element.triggerHandler('hide-popover');
                                        });
                                    }
                                });
                            }
                        };
                        return directive;
                    }];
            };

            PopoverToggle.directive = directiveFactory();
        })(Directives.PopoverToggle || (Directives.PopoverToggle = {}));
        var PopoverToggle = Directives.PopoverToggle;
    })(App.Directives || (App.Directives = {}));
    var Directives = App.Directives;
})(App || (App = {}));