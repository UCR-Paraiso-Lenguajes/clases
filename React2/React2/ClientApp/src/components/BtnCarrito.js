import React, { Component } from 'react';
import { Col, Grid, Row, Button, Glyphicon } from 'react-bootstrap';


export class BtnCarrito extends Component {
    displayName = BtnCarrito.name

    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div>
                <Glyphicon glyph="shopping-cart" />
                <img src="https://www.gravatar.com/avatar/2a37a89c72019ccdf659b58b6746c653?s=40&r=pg" />
            </div>
        );
    }
}
