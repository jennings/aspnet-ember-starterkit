﻿window.App = Ember.Application.create();

App.Router.map(function () {
    this.resource('application', { path: '/' });
});
